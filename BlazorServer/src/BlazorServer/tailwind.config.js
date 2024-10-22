/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './**/*.html',
        './**/*.razor',
        './**/*.razor.css',
        './wwwroot/index.html',
        './**/*.cs',
        './**/*.razor.cs',
        './**/*.cshtml',
    ],
    theme: {
        extend: {},
    },
    plugins: [
        function ({ addComponents }) {
            addComponents({
                'h1': {
                    '@apply text-4xl font-bold text-gray-800 leading-tight mb-4': {},
                },

                // h2 styles
                'h2': {
                    '@apply text-3xl font-semibold text-gray-800 leading-tight mb-4': {},
                },

                // h3 styles
                'h3': {
                    '@apply text-2xl font-semibold text-gray-700 leading-tight mb-3': {},
                },

                // h4 styles
                'h4': {
                    '@apply text-xl font-medium text-gray-600 leading-tight mb-2': {},
                },
                '.btn-primary': {
                    '@apply px-4 py-2 bg-blue-500 text-white font-semibold rounded-lg shadow-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-400 focus:ring-opacity-75 transition duration-200 ease-in-out': {},
                },
                '.btn-secondary': {
                    '@apply px-4 py-2 bg-gray-500 text-white font-semibold rounded-lg shadow-md hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-gray-400 focus:ring-opacity-75 transition duration-200 ease-in-out': {},
                },
                // Label styles
                '.label': {
                    '@apply text-sm font-semibold text-gray-700 mb-2': {},
                },

                // Input text styles
                '.input-text': {
                    '@apply w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-blue-200 focus:border-blue-500': {},
                },

                // Text area styles
                '.input-textarea': {
                    '@apply w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-blue-200 focus:border-blue-500': {},
                },

                // Select element styles
                '.select': {
                    '@apply w-full p-2 border border-gray-300 rounded-lg bg-white text-gray-700 focus:ring focus:ring-blue-200 focus:border-blue-500': {},
                },

                // Option element styles
                '.option': {
                    '@apply text-gray-700': {},
                },

                // DateTime input styles
                '.input-datetime': {
                    '@apply w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-blue-200 focus:border-blue-500': {},
                },

                // Form-group for spacing between elements
                '.form-group': {
                    '@apply space-y-4': {},
                },
            })
        },
    ],
}