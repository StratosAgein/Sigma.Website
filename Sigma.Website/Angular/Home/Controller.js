Sigma.controller("HomeController", function ($scope, $window, HomeService) {

    $scope.showAddUpdate = false;
    $scope.LoginButtonText = "Login";
    $scope.WelcomeText = "Welcome";

    $scope.submitToLogin = function () {
        $scope.MVCAction = "Login";
        $scope.MVCController = "Dashboard";

        $scope.LoginButtonText = "Validating...";
        var loginProcess = HomeService.Login($scope.Company, $scope.Username, $scope.Password);

        loginProcess.then(function (response) {
            
            if (response.data.Authentication.Success == true) {
                if (typeof (Storage) !== "undefined") {
                    $scope.WelcomeText = "Loading your experience";
                    $scope.LoginButtonText = "Login";
                    localStorage.setItem('AccessToken', response.data.Authentication.Token);

                    $window.location.href = '/Dashboard/Index?Company=' + $scope.Company;
                } else {
                    // Sorry! No Web Storage support..
                }
            }
            else {
                $scope.WelcomeText = "Something was wrong, please verify email and password";
                $scope.LoginButtonText = "Retry";
            }
        },
        function (response) {
            switch (response.status) {
                case 500:
                    $scope.LoginButtonText = "Retry";
                    alert('Servicio no disponible, intente más tarde');
                    break;
                default:
                    $scope.LoginButtonText = "Retry";
                    alert('Error desconocido');
                    break;
            }
        })
    }
});