var app = angular.module('my-app', []);
app.controller('receiptAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/receipt").then(function(resp){
        $scope.receipts = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('receiptDeleteCtrl', function ($scope, $http) {
    $scope.deleteReceipt = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this receipt?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/receipt/delete/" + id).then(function(resp){
                
            alert("Failed to delete receipt!");
            }, function (err) {
                location.reload();

                alert("Receipt deleted successfully!");
                console.log(err);
            });
        }
    };
});