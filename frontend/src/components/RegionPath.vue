<template>
  <path
      :index='index'
      :d='region.path'
      ref="path"
      :fill="getColor"
      class='state'
      @mouseover='isActive = true'
      @mouseout='isActive = false'
      @click="showTitleDialog(region)"
      :class='{ regionActive: isActive}'/>
</template>

<script>
export default {
  props: {
    region: Object,
    index: Number
  },

  data() {
    return {
      isActive: false
    };
  },
  computed:
      {
        getColor() {
          return this.getColorForPercentage(this.region.value)
        }
      },
  methods: {
    showTitleDialog(region) {
      console.log(region);
      this.$modal.show('dialog', {
        title: region.fed_okrug + '<br/><br/>' + region.name,
        text: 'Коэффициент: ' + region.value + '<br/>'
      })
    },
    getColorForPercentage(pct) {
      let i;
      const percentColors = [
        {pct: 0.0, color: {r: 0xff, g: 0x00, b: 0x00}},
        {pct: 0.25, color: {r: 0xff, g: 0x80, b: 0x00}},
        {pct: 0.5, color: {r: 0xff, g: 0xff, b: 0x00}},
        {pct: 0.75, color: {r: 0x80, g: 0xff, b: 0x00}},
        {pct: 1.0, color: {r: 0x00, g: 0xff, b: 0x00}}
      ];
      for (i = 1; i < percentColors.length - 1; i++) {
        if (pct < percentColors[i].pct) {
          break;
        }
      }
      const lower = percentColors[i - 1];
      const upper = percentColors[i];
      const range = upper.pct - lower.pct;
      const rangePct = (pct - lower.pct) / range;
      const pctLower = 1 - rangePct;
      const pctUpper = rangePct;
      const color = {
        r: Math.floor(lower.color.r * pctLower + upper.color.r * pctUpper),
        g: Math.floor(lower.color.g * pctLower + upper.color.g * pctUpper),
        b: Math.floor(lower.color.b * pctLower + upper.color.b * pctUpper)
      };
      return 'rgb(' + [color.r, color.g, color.b].join(',') + ')';
    }
  }
};
</script>
