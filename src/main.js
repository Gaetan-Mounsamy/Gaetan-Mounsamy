import { createApp } from 'vue'
import App from './App.vue'
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome"
import { library } from "@fortawesome/fontawesome-svg-core"
import { faHouseUser, faUserCircle, faCircleNotch } from "@fortawesome/free-solid-svg-icons"


library.add(faHouseUser, faUserCircle, faCircleNotch)
createApp(App)
    .component('FontAwesomeIcon', FontAwesomeIcon)
    .mount('#app')


export { FontAwesomeIcon }