'use strict';
appGeral.controller('trabalhoController', function ($scope, $http) {

    var trabalho = {
        contador:0,
        Id: "",
        Tema: "",
        Descricao: "",
        DataApresentacao: "",
        Ativo:false
    }

    $scope.trabalhos = [];
    
    $scope.listarTrabalhos = function() {
        $http({
            url: 'Api/trabalhos/Listar',
            method: 'GET'
        }).success(function (data) {
            $scope.trabalhos.length = 0;
            angular.forEach(data, function (value, key) {
                trabalho.contador = key;
                trabalho.Id = data[key].Id;
                trabalho.Tema = data[key].Tema;
                trabalho.Descricao = data[key].Descricao;
                trabalho.DataApresentacao = data[key].DataApresentacao;
                trabalho.Ativo = data[key].Ativo;

                $scope.trabalhos.push(angular.copy(trabalho));
            });
            return $scope.trabalhos;
        });
        
    }
});