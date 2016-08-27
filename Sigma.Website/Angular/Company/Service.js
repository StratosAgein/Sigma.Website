Sigma.service("CompanyService", function ($http) {
    //GetAll
    this.GetCompanies = function () {
        return $http.get("Company/GetAllCompanies");
    };
    //GetById
    this.GetCompany = function (CompanyId) {
        var response = $http({
            method: "post",
            url: "Company/GetCompanyById",
            params: {
                CompanyId: JSON.stringify(CompanyId)
            }
        });
        return response;
    }
});