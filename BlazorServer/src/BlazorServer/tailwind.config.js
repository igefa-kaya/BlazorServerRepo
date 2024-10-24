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
        './src/**/*.{css,html,js,ts}',
    ],
    theme: {
        fontFamily: {
            sans: ['Mulish', 'system-ui', 'sans-serif'],
        },

        fontWeight: {
            normal: '400',
            semibold: '600',
            extrabold: '800',
        },

        colors: {
            warning: '#FFA800',
            danger: '#B71312',
            primary: '#003858',
            info: '#4AC0E7',
            success: '#18A157',
            notice: '#fff9ee',
        },

        extend: {
            zIndex: {
                10000: '10000',
                8000: '8000',
            },
            spacing: {
                fit: 'fit-content',
                full: '100%',
                4.5: '1.125rem',
            },
            fontSize: {
                xxs: ['10px', '12px'],
                xxl: ['32px', '150%'],
            },
            opacity: {
                97: '97%',
            },
            colors: {
                transparent: 'transparent',
                current: 'currentColor',

                industry: {
                    industrial: {
                        flat: '#FFA800',
                        DEFAULT: '#fdc300',
                    },
                    health: '#67c0b5',
                    facility: '#1d70b7',
                    gastronomy: '#c2416f',
                    cleaning: '#76b72a',
                    wellness: '#003858',
                },

                primary: {
                    // ->blue-navy
                    // default for buttons and links, table headline, headlines
                    hover: '#003858',
                    active: '#003858',
                    text: '#003858',
                    DEFAULT: '#003858', // Changes color for class text-danger
                },

                danger: {
                    // ->blue-navy
                    // default for buttons and links, table headline, headlines
                    hover: '#DA5150',
                    active: '#8E0100',
                    text: '#B71312',
                    DEFAULT: '#B71312', // Changes color for class text-danger
                },

                success: {
                    // ->blue-navy
                    // default for buttons and links, table headline, headlines
                    hover: '#18A157',
                    active: '#18A157',
                    'flat-light': '#F4FFF7',
                    text: '#18A157',
                    DEFAULT: '#18A157', // Changes color for class text-danger
                },

                info: {
                    // ->blue-navy
                    // default for buttons and links, table headline, headlines
                    hover: '#4AC0E7',
                    active: '#1D70B7',
                    text: '#1D70B7',
                    DEFAULT: '#1D70B7', // Changes color for class text-danger
                },

                warning: {
                    // ->blue-navy
                    // default for buttons and links, table headline, headlines
                    hover: '#faab1a',
                    active: '#FFA800',
                    text: '#FF9900',
                    'flat-light': '#FFF9EE', // for light background
                    flat: '#FDC300',
                    DEFAULT: '#FFA800', // Changes color for class text-danger
                },

                // The color sheme represents the interface Palette
                // @todo (kind is the porameter name at the moment. This could lead to misunderstanding.)
                // warning : '#FFA800',
                // danger  : '#B71312',
                // primary : '#003858',
                // info    : '#4AC0E7',
                // success : '#18A157',

                // @todo The name of the color definitions here needed to be defined by usage and not by their color name
                white: '#ffffff',
                'white-opac': 'rgb(255 255 255 / 97%)',
                'blue-navy': {
                    // default for buttons and links, table headline, headlines
                    hover: '#015F95',
                    active: '#165081',
                    DEFAULT: '#003858',
                },
                'blue-medium': {
                    //active elements. highlight color, headlines
                    hover: '#2683D2',
                    DEFAULT: '#1D70B7',
                },
                'blue-signal': '#4AC0E7',
                'blue-soft': '#F1F9FF', //'#F0F7FD',
                'blue-soft-hover': '#E4F2FF',
                'gray-dark': {
                    // default text color
                    hover: '#3A3A3A',
                    DEFAULT: '#101010',
                },
                'gray-medium': '#606060', // text'
                'gray-light': '#ced3e0', //'#D7DCE0', // border
                'green-medium': {
                    hover: '#1BC569',
                    active: '#008052',
                    DEFAULT: '#18A157', // green for shopping cart, finish states etc.
                },
                'green-soft': '#F4FFF7', // background color table rows (selected items for cart)
                'bluegray-medium': '#687E8A', //for light gray text
                'bluegray-soft': '#F0F3F4', // background for table header, selection bar...
                gray: {
                    100: '#F4F7F8',
                },
                orange: {
                    DEFAULT: '#CA7D00',
                },
                red: {
                    hover: '#DA5150',
                    active: '#8E0100',
                    DEFAULT: '#B71312',
                    900: 'rgb(127 29 29)',
                    600: 'rgb(220 38 38)',
                    500: 'rgb(239 68 68)',
                },
                'red-light': '#FFF5F5',
                yellow: '#FFA800',
                'yellow-light': '#FFF9EE',
                'yellow-dark': '#F79B12',
            },
            dropShadow: {
                'top-lg': '0 0 10px rgb(0 0 0 / 0.1)',
            },
        },
        plugins: [],
    },
}