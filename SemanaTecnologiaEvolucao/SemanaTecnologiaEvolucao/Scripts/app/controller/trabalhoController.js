'use strict';
appGeral.controller('trabalhoController', function ($scope, $http) {

    var trabalho = {
        contador:0,
        Id: "",
        Tema: "",
        Descricao: "",
        DataApresentacao: "",
        Ativo: false,
        Status: "",
        css:""
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
                if (data[key].Ativo == true) {
                    trabalho.Status = "Ativo";
                    trabalho.css = "label label-success";
                } else {
                    trabalho.css = "label label-danger";
                    trabalho.Status = "Inativo";
                }

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

    $scope.editar = function (trabalho) {
        $http({
            url: 'Api/trabalhos/editar',
            method: 'POST',
            data: trabalho
        }).success(function (data) {
            $scope.listarTrabalhos();
        });
    }

    $scope.incluir = function (trabalho) {
        $http({
            url: 'Api/trabalhos/incluir',
            method: 'POST',
            data: trabalho
        }).success(function (data) {
            $scope.listarTrabalhos();
        });
    }

    $scope.excluir = function (codigo) {
        $http({
            url: 'Api/trabalhos/excluir/'+codigo,
            method: 'POST'
        }).success(function (data) {
            $scope.listarTrabalhos();
        });
    }
});