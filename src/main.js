import { createApp } from 'vue'
import App from './App.vue'
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome"
import { library } from "@fortawesome/fontawesome-svg-core"
import { faHome, faUser } from "@fortawesome/free-solid-svg-icons"


library.add(faHome, faUser)
createApp(App)
    .component('FontAwesomeIcon', FontAwesomeIcon)
    .mount('#app')


export { FontAwesomeIcon }