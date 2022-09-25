<template>
  <div style="text-align: center">
      <p>Youpi ma premiere page en Vue.</p>

    <base-button>
      <p>BaseButton</p>
    </base-button>

    <br>
    <base-button disabled>
      <p>BaseButton disabled</p>
    </base-button>

    <br>
    <base-button color="warn">
      <p>BaseButton colors props</p>
    </base-button>

    <br>
    <base-button color="danger">
      <p>BaseButton colors props v2</p>
    </base-button>

    <br>
    <async-button @click="wait">
      desactive x seconde à chaque click
    </async-button>

  </div>
</template>

<script>
  import AsyncButton from '../components/AsyncButton.vue'
  import BaseButton from "@/components/BaseButton";

  export default
  {
    name: 'HomePage',
    components: {BaseButton, AsyncButton},
    methods: {
      wait()
      {
        return new Promise(resolve => setTimeout(resolve, 2000))
      }
    }
  }
</script>
