<template>
  <div>
    <h1>{{result}}</h1>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'HelloWorld',
  data () {
    return {
      result: 'string'
    }
  },
  methods: {
    test () {
      console.log('test api')
      axios.get('/api/values').then(response => {
        console.log(response)
      })
    }
  },
  mounted () {
    this.test()
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>