﻿'use strict';
appGeral.factory('authService', ['$http', '$q', 'localStorageService', '$cookieStore', '$cookies', function ($http, $q, localStorageService, $cookieStore, $cookies) {

    var serviceBase = 'http://localhost:3966/';
    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };

    var _saveRegistration = function (registration) {

        _logOut();

        return $http.post(serviceBase + 'api/account/register', registration).then(function (response) {
            return response;
        });

    };

    var _login = function (loginData) {

        var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

        var deferred = $q.defer();

        $http.post(serviceBase + '/token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).success(function (response) {

            localStorageService.set('authorizationData', { token: response.access_token, userName: loginData.userName, nomeDescricao: response.userName});

            _authentication.isAuth = true;
            _authentication.userName = loginData.userName;
            deferred.resolve(response);

        }).error(function (err, status) {
            _logOut();
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _logOut = function () {

        var authData = localStorageService.get('authorizationData');

        if (authData != null) {
            $http({
                method: 'POST',
                url: serviceBase + 'api/account/Logout',
                headers: { 'Authorization': 'bearer ' + authData.token }
            });
        }
        localStorageService.remove('authorizationData');       
        _authentication.isAuth = false;
        _authentication.userName = "";
        //$location.path('/Dashboard');
        window.location.href = '/Home';
    };

    var _fillAuthData = function () {
        var authData = localStorageService.get('authorizationData');
        if (authData) {
            _authentication.isAuth = true;
            _authentication.userName = authData.userName;
        }
    }

    authServiceFactory.saveRegistration = _saveRegistration;
    authServiceFactory.login = _login;
    authServiceFactory.logOut = _logOut;
    authServiceFactory.fillAuthData = _fillAuthData;
    authServiceFactory.authentication = _authentication;
    return authServiceFactory;
}]);