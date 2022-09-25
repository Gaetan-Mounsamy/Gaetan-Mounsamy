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

  </div>
</template>

<script>

  import BaseButton from "@/components/BaseButton";

  export default
  {
    name: 'HomePage',
    components: {BaseButton},
  }
</script>
