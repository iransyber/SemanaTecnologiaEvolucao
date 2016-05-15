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
    $scope.infotrabalho = {
        contador: 0,
        Id: "",
        Tema: "",
        Descricao: "",
        DataApresentacao: "",
        Ativo: false
    }
    
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

    $scope.visualizar = function(codigo) {
        $http({
            url: 'Api/trabalhos/info/' + codigo,
            method: 'GET'
        }).success(function (data) {
            angular.forEach(data, function (value, key) {
                $scope.infotrabalho.contador = key;
                $scope.infotrabalho.Id = data[key].Id;
                $scope.infotrabalho.Tema = data[key].Tema;
                $scope.infotrabalho.Descricao = data[key].Descricao;
                $scope.infotrabalho.DataApresentacao = data[key].DataApresentacao;
                $scope.infotrabalho.Ativo = data[key].Ativo;
            });
            return $scope.infotrabalho;
        });
    }
});