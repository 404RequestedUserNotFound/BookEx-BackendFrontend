var app = angular.module('my-app', []);
app.controller('receiptSearchCtrl', function($scope, $http) {
    $scope.searchReceipt = function() {
        $http.get("https://localhost:44373/api/receipt/" + $scope.receiptId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});
