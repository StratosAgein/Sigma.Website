var Sigma = angular.module('Sigma', ['ngRoute']);

Sigma.factory('TokenInjector', ['$log', '$q', '$location', function ($log, $q) {
    

    var TokenInjector = {
        request: function (config) {
            
            if (localStorage.getItem("AccessToken") != undefined && localStorage.getItem("AccessToken") != null) {
                config.headers['x-access-token'] = localStorage.getItem("AccessToken");
                
                return config;
            }
            else if (config.url === '/Dashboard/Login') {
                return config;
            }
            return null;
        }
    }

    return TokenInjector;
}]);

Sigma.config(['$httpProvider', function ($httpProvider) {
    $httpProvider.interceptors.push('TokenInjector');
}]);