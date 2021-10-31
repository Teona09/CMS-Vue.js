<template>
  <div class="footer">
    <a v-bind:href="gitLink"> GitHub Repo</a>
  </div>
</template>

<script>
export default {
  data() {
    return {
      gitLink: "https://github.com/Teona09/CMS-Vue.js",
    };
  },
};
</script>

<style>
.footer {
  position: fixed;
  bottom: 0;
  left: 0;
  height: 2%;
  width: 100%;
  background-color: var(--light-orange);
  padding: 0.625rem;
  font-weight: bolder;
  color: var(--orange);
  display: flex;
  justify-content: center;
}
</style>
