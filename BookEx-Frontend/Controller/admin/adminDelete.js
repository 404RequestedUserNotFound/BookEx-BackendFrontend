var app = angular.module('my-app', []);
app.controller('adminAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/admin").then(function(resp){
        $scope.admins = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('adminDeleteCtrl', function ($scope, $http) {
    $scope.deleteAdmin = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this admin?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/admin/delete/" + id).then(function(resp){
                
            alert("Failed to delete admin!");
            }, function (err) {
                location.reload();

                alert("Admin deleted successfully!");
                console.log(err);
            });
        }
    };
});