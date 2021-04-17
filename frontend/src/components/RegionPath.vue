<template>
  <path
      :index='index'
      :d='region.path'
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
  methods: {
    showTitleDialog(region) {
      console.log(region);
      this.$modal.show('dialog', {
        title: region.fed_okrug + '<br/><br/>' + region.name,
        text: 'Коэффициент: ' + region.value + '<br/>'
      })
    },
  }
};
</script>

<style>
</style>
