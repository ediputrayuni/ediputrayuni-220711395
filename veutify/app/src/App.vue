<template>
  <v-app>
  <div id="app">
    <img src="./assets/logo-unri2.png" height="75" widht="300">
    <web-toolbar></web-toolbar>
      <router-view/>
    <web-footer></web-footer>
  </div>
  </v-app>
</template>

<script>
import WebFooter from'./components/WebFooter'
import WebToolbar from'./components/WebToolbar'

export default {
  name: 'App',
  components:{WebFooter,WebToolbar}
}
</script>

<style>
#app {
  font-family: 'Avenir',Helvitica, Arial, sans-serif;
  -webkit-font-smooting: antialiased;
  -moz-osx-font-smooting: grayscale;
  text-align: left;
  color:rgba(8, 154, 22, 0.933);
}
</style>
