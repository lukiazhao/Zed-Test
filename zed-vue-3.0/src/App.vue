<template>
    <div id="app">
        
        <!-- Navigation bar -->
        <div class="container">
            <Navbar></Navbar>
        </div>

        <!-- Router View  -->
        <div class="container">
            <router-view/>
        </div>

        <!-- Footer -->
        <footer class="layout_footer">
            <Footer/>
        </footer>
    </div>
</template>

<script>
import Navbar from '@/layouts/Navbar'
import Footer from '@/layouts/Footer'

export default {
    components: {
        Navbar,
        Footer
    }
}
</script>

<style>
    @import './../css/style.css';
</style>
