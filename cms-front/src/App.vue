<template>
  <!-- Header -->
  <!-- Content -->
  <Content></Content>
  <!-- Footer -->
</template>

<script>
import Content from "./components/Content/Content.vue";

export default {
  name: "App",
  components: {
    Content,
  },
};
</script>

<style>
:root {
  --pastel-yellow: #fcf8e8;
  --pastel-light-green: #d4e2d4;
  --light-orange: #ecb390;
  --orange: #df7861;
}

* {
  background-color: var(--pastel-yellow);
  margin: 0;
  padding: 0;
}

#app {
  box-sizing: border-box;
  font-family: Arial, Helvetica, sans-serif;
  height: 100vh;
  overflow: hidden;
}
</style>
