<template>
  <div>
    <b-navbar toggleable="lg" type="light" variant="light">
    <b-navbar-brand href="/"><img src="../assets/company_logo.png" id="company_logo" alt="company_logo">
    </b-navbar-brand>

    <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

    <b-collapse id="nav-collapse" is-nav>
      <b-navbar-nav>
        <b-nav-item :to="{ name: 'study'}">Study</b-nav-item>
      </b-navbar-nav>
    </b-collapse>
  </b-navbar>
  </div>
</template>

<script>
export default {
  name: 'Navbar'
}
</script>

<style scoped>
#company_logo {
  height:50px;
}
.nav-item {
  font-size: 21px;
  font-weight: bold;
  margin-left: 40px;
}
.navbar-light .navbar-nav .nav-link {
  color: #4BA7DB;
}
</style>
