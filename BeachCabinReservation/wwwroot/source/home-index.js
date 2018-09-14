
console.log("home-index.js is loaded");

//get config
var config = $("#config").html();
if (config) {
    console.log(JSON.parse(config));
}
//get urls
var urls = $("#urlConfig").html();
if (urls) {
    console.log(JSON.parse(urls));
}