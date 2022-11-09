// JS Dependencies: Popper, Bootstrap & JQuery
import '@popperjs/core';
import 'bootstrap';
import 'jquery';
// Using the next two lines is like including partial view _ValidationScriptsPartial.cshtml
import 'jquery-validation';
import 'jquery-validation-unobtrusive';

import '../scss/custom.scss';

// Custom JS imports
import '../js/customGeneral';
import '../js/customJqueryValidate';

// Custom CSS imports
import '../css/site.css';

import $ from 'jquery';
window.jQuery = $;
window.$ = $;