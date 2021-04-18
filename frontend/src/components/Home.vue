<template>
  <div>
    <b-select v-model="selected" :options="options"></b-select>
    <div class="wrapper" @click="goEvent($event)">
      <div class="wrapper-title">{{ msg }}</div>
      <RussianMap/>
      <v-dialog/>
      <PulseMarker v-if="x && y" :pointX="x" :pointY="y"/>
    </div>
    <img src="/legend.jpg" alt="image can't be displayed" style="float: right"/>
    <img src="/chart.png" alt="image can't be displayed" height="500px" style="float: left"/>
  </div>
</template>

<script>
import RussianMap from "./RussianMap";
import PulseMarker from "./PulseMarker";

export default {
  props: {
    msg: String
  },
  data() {
    return {
      x: null,
      y: null,
      selected: 0,
      options: [
        {value: 0, text: 'Все IT-направления'},
        {value: 1, text: 'Программная инженерия'},
        {value: 2, text: 'Информатика и вычислительная техника'},
        {value: 3, text: 'Прикладная информатика'},
        {value: 4, text: 'Информационные системы и технологии'},
        {value: 5, text: 'Математическое обеспечение и администрирование информационных систем'},
        {value: 6, text: 'Прикладная математика и информатика'},
        {value: 7, text: "Фундаментальная информатика и информационные технологии"}
      ]
    };
  },
  methods: {
    goEvent(event) {
      this.x = event.x - 25;
      this.y = event.y - 25 + window.scrollY;
    }
  },
  components: {
    RussianMap,
    PulseMarker
  }
};
</script>

<style lang="less">
* {
  margin: 0;
  padding: 0;
}

.wrapper {
  margin: 0;
  height: 100%;
  overflow: hidden;

  .wrapper-title {
    position: absolute;
    margin-left: auto;
    margin-right: auto;
    left: 0;
    right: 0;
    font-size: 72px;
    z-index: 2;
    -moz-user-select: none;
    user-select: none;
  }
}
</style>
