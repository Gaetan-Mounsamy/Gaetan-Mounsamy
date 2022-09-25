<template>
  <base-layout>
    <home-page />
  </base-layout>
</template>

<script>
  import BaseLayout from './components/BaseLayout.vue'
  import HomePage from './pages/HomePage.vue'

  export default
  {
    name: 'App',
    components: {
      HomePage,
      BaseLayout
    }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
