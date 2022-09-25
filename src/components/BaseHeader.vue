<template>
  <header class="base-header">
    <div class="Home">
      <base-button>
        <font-awesome-icon class="icon" :icon="['fas', 'house-user']" /> Acceuil
      </base-button>

      <div class="connection" />

      <base-button>
        <font-awesome-icon class="icon" :icon="['fas', 'user-circle']" /> Vous n'êtes pas connecté
      </base-button>

    </div>
  </header>
</template>

<script>
  import BaseButton from "@/components/BaseButton";
  export default
  {
    name: 'BaseHeader',
    components: {BaseButton},
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
