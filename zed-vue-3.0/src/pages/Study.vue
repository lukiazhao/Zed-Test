<template>
    <div>
        <b-container fluid>
            <!-- Seach Box -->
            <b-container class="mt-3">
                <b-row align-h="end">
                    <b-form inline>
                        <b-input class="search_bar" type="text" v-model="search_text" placeholder="Search GUID" @keyup.enter="onSearch"></b-input>
                        <b-button variant="primary" size="md" @click="onSearch">Search</b-button>
                    </b-form>
                </b-row>
            </b-container>
            <!-- Study Table -->
            <StudiesTable :studies=studies></StudiesTable>
        </b-container>

        <!-- GUID not found modal -->
        <div>
            <b-modal id="modal-center" ref="notfound_modal" centered title="Error">
                <p class="my-4">{{ error_message }}</p>
            </b-modal>
        </div>
    </div> 
</template>

<script>
import StudiesTable from '@/components/StudiesTable'
import axios from 'axios'

export default {
    components: {
        StudiesTable
    },
    data () {
        return {
            studies: null,
            search_text: null,
            show_table: true,
            error_message: '',
        }
    },
    methods: {
        /*
            Get all studies 
         */
        loadStudies() {
            var temp = []
            axios.get('/api/study').then(response => {
                if (response.status == 204) {
                    this.error_message = `Study not found`
                    this.$refs['notfound_modal'].show()
                } else {
                    response.data.forEach(study => temp.push(study))
                }
            })
            this.studies = temp;
        },
        /*
            Get Study by GUID 
         */
        onSearch() {
            if (this.search_text) {
                axios.get('/api/study/' + this.search_text).then(response => {
                    if (response.status == 204) {    // No Content success
                        // show modal
                        this.error_message = `Study(${ this.search_text }) does not exist. `
                        this.$refs['notfound_modal'].show()
                    } else {
                        this.studies = [response.data];
                    } 
                })
            } else {
                // No search text -> Get all studies.
                this.loadStudies();
            }
        }
    },
    created () {
        this.loadStudies();
    }
}
</script>

<style scoped>
.search_bar {
    width:400px;
}
</style>