/*
Helper utility functions
*/

// Show success message
export const showSuccess = (message) => {

alert("Success: " + message)

}

// Show error message
export const showError = (message) => {

alert("Error: " + message)

}

// Format date for display
export const formatDate = (date) => {

const d = new Date(date)

return d.toLocaleDateString()

}

// Get query parameter from URL
export const getQueryParam = (param) => {

const urlParams = new URLSearchParams(window.location.search)

return urlParams.get(param)

}

// Simple loader display
export const showLoader = () => {

const loader = document.getElementById("loader")

if(loader){
    loader.style.display = "block"
}

}

// Hide loader
export const hideLoader = () => {

const loader = document.getElementById("loader")

if(loader){
    loader.style.display = "none"
}

}
