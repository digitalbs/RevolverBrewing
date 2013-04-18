'use strict';


// Declare app level module which depends on filters, and services
angular.module('RevolverBrewing', ['RevolverBrewing.filters', 'RevolverBrewing.services', 'RevolverBrewing.directives']).
  config(['$routeProvider', function($routeProvider) {
      $routeProvider.when('/Home/Admin', { controller: AdminCtrl });
    $routeProvider.otherwise({redirectTo: '/Home'});
  }]);
