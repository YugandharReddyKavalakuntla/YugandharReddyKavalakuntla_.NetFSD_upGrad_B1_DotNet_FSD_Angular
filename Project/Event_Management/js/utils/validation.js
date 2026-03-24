/*
Utility functions for form validation
*/

// Check if value is empty
export const isRequired = (value) => {
return value && value.trim() !== ""
}

// Validate email
export const isValidEmail = (email) => {

const pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
return pattern.test(email)

}

// Validate phone number (10 digits)
export const isValidPhone = (phone) => {

const pattern = /^[0-9]{10}$/
return pattern.test(phone)

}

// Check if date is not in the past
export const isFutureDate = (date) => {

const selectedDate = new Date(date)
const today = new Date()

today.setHours(0,0,0,0)

return selectedDate >= today

}

// Validate positive number
export const isPositiveNumber = (value) => {

return Number(value) > 0

}
