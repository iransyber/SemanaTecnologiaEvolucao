'use strict';
appGeral.controller('indexController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.logOut = function () {
        authService.logOut();
        $location.path('/Home');
    }

    $scope.authentication = authService.authentication;

}]);