(function () {

    'use strict';

    function route($routeProvider) {
        $routeProvider
			.when('/books/edit/:idBook', {
			    templateUrl: 'booksEditView.html',
			})
            .when('/', {
                templateUrl: 'booksListView.html',
            })
			.otherwise({
			    redirectTo: '/'
			});
    }

    angular
		.module('booksSeller')
		.config(route);

})();