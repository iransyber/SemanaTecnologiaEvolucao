'use strict';
appGeral.controller('trabalhoController', function ($scope, $http) {
    $scope.listarTrabalhos = function() {
        $http({
            url: 'Api/trabalhos/Listar',
            method: 'GET'
        }).success(function(data) {
            console.log(data);
        });
    }
});