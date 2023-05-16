var app = angular.module('my-app', []);

app.controller('customerSearchCtrl', function($scope, $http) {
    $scope.customerId = "";
    $scope.customer = null;

    $scope.searchCustomer = function() {
        var url = "https://localhost:44373/api/customer/" + $scope.searchId;
        $http.get(url)
            .then(function(resp) {
                $scope.customer = resp.data;
            })
            .catch(function(err) {
                console.log(err);
                $scope.customer = null;
            });
    };
});
