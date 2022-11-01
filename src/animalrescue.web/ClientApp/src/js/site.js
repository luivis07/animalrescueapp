// JS Dependencies: Popper, Bootstrap & JQuery
import '@popperjs/core';
import 'bootstrap';
import 'jquery';
// Using the next two lines is like including partial view _ValidationScriptsPartial.cshtml
import 'jquery-validation';
import 'jquery-validation-unobtrusive';

import '../scss/custom.scss';

// Custom JS imports
// ... none at the moment

// Custom CSS imports
import '../css/site.css';

var $ = require("jquery");
window.jQuery = $;
window.$ = $;

(function($){
    $(".ssar-link-group").addClass("row text-center");
})(jQuery)