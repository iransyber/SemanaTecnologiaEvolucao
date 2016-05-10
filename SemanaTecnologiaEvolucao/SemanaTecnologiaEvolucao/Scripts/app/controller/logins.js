var app = angular.module('appapi', []);




//app.controller('logincontroller', function($scope, $http) {
//    $scope.credenciais = { username: "", access_token: "", token_type: "" };
//    $scope.userlogin = { username: "", password: "" };

//    $scope.login = function (userlogin) {
//        $http({
//            url: "/TOKEN",
//            method: "POST",
//            data: $.param({ grant_type: 'password', username: userlogin.username, password: userlogin.password }),
//            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
//        }).success(function (data) {
//            $scope.LoginOn(data);
//        });
//    };

//    $scope.LoginOn = function(token) {
//        $http({
//            url:"/dashboard/index",
//            method: "GET",
//            headers: { "Authorization": token.token_type + " " + token.access_token }
//        }).success(function() {
//            window.location.href = '/dashboard/index';
//        });
//    };

//    $scope.Logout = function () {
//            $http({
//                url: "/api/Account/Logout",
//                method: "POST",
//                headers: {
//                    "Authorization": token.token_type + " " + token.access_token
//                }
//            });
//    }
//});
