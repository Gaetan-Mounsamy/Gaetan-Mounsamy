<template>
  <div>
    <base-header />
    <home-page />
    <base-footer />
  </div>
</template>

<script>
import HomePage from "@/pages/HomePage";
import BaseHeader from "@/components/BaseHeader";
import BaseFooter from "@/components/BaseFooter";
export default {
  name: 'App',
  components: {
    BaseFooter,
    BaseHeader,
    HomePage
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
