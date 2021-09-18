<template>
  <!-- Header -->
  <Header></Header>
  <!-- Content -->
  <Content></Content>
  <!-- Footer -->
  <Footer></Footer>
</template>

<script>
import Header from "./components/Header.vue";
import Content from "./components/Content/Content.vue";
import Footer from "./components/Footer.vue";

export default {
  name: "App",
  components: {
    Header,
    Content,
    Footer,
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
