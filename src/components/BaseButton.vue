<template>
  <button
      class="button"
      :style="getCssVariables"
  >
    <slot />
  </button>
</template>

<script>
  const colorPalette = {
    primary: { bg: '#42b983', hoverBg: '#4cce93', focusBorder: '#47d696' },
    warn: { bg: '#ff5722', hoverBg: '#ff7043', focusBorder: '#ff8a65' },
    danger: { bg: '#e53935', hoverBg: '#ef5350', focusBorder: '#e57373' },
  }

  export default
  {
    name: 'BaseButton',
    props: {
      color: {
        default: 'primary',
      }
    },
    computed: {
      getCssVariables ()
      {
        return {
          '--button-background-color': colorPalette[this.color].bg,
          '--button-hover-background-color':  colorPalette[this.color].hoverBg,
          '--button-focus-boder': colorPalette[this.color].focusBorder
        }
      }
    }
  }
</script>

<style>
  .button
  {
    padding: 0.5em;
    background-color: var(--button-background-color);
    border: none;
  }

  .button:hover
  {
    background-color: var(--button-hover-background-color);
  }

  .button:focus
  {
    padding: calc(0.5em - 2px);
    border: 2px solid var(--button-focus-boder);
  }

  .button:disabled
  {
    opacity: 0.7;
    cursor: not-allowed;
  }
</style>
