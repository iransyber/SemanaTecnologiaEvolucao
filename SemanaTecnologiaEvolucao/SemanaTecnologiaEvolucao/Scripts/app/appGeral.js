var appGeral = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar', 'ngCookies']);

appGeral.config(function ($routeProvider) {

    $routeProvider.when("/Home", {
        controller: "HomeController",
        templateUrl: "~/views/Home/Index.cshtml"
    });

    $routeProvider.when("/Dashboard", {
        controller: "dashboardController",
        templateUrl: "/views/Dashboard/Index.cshtml"
    });

    $routeProvider.when("/CadastroTrabalhos", {
        controller: "CadastroTrabalhosController",
        templateUrl: "views/CadastroTrabalhos/Index.html"
    });

    $routeProvider.otherwise({ redirectTo: "/Home" });
});

var serviceBase = 'http://localhost:3966/';
appGeral.constant('ngAuthSettings', {
    apiServiceBaseUri: serviceBase,
    clientId: 'ngAuthApp'
});

appGeral.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

appGeral.run(['authService', function (authService) {
    authService.fillAuthData();
}]);