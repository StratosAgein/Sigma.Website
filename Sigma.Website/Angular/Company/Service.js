Sigma.service("CompanyService", function ($http) {
    //GetAll
    this.GetCompanies = function () {
        return $http.get("Company/GetAllCompanies");
    };
});