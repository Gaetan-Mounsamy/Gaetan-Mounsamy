<template>
  <header class="base-header">
    <div class="Home">
      <font-awesome-icon class="icon" :icon="['fas', 'home']" /> Acceuil

      <div class="connection" />

      <font-awesome-icon class="icon" :icon="['fas', 'user']" /> Vous n'êtes pas connecté

    </div>
  </header>
</template>

<script>
  export default
  {
    name: 'BaseHeader',
  }
</script>

<style scoped>

  .base-header
  {
    background-color: lightseagreen;
    padding: 1.0em;
  }

  .Home
  {
    display: flex;
    max-width: 100em;
    margin: auto;
    color: black;
  }

  .connection
  {
    flex-grow: 10;
  }

  .icon
  {
    margin-right: 0.7em;
  }

</style>
