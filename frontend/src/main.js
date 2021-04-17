import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vmodal from 'vue-js-modal'
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import SvgFiller from 'vue-svg-filler'

Vue.use(vmodal, {dialog: true})
Vue.use(BootstrapVue)

Vue.component('svg-filler', SvgFiller)
Vue.config.productionTip = false
new Vue({
    router,
    render: h => h(App)
}).$mount('#app')
