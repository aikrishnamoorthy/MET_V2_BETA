var app = angular.module('metApp', ['infinite-scroll']);

app.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false //http://stackoverflow.com/questions/32098585/angularjs-error-locationnobase
    });
}]);

