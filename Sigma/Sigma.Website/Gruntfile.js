module.exports = function (grunt) {

    grunt.initConfig({
        "bower-install-simple": {
            options: {
                color: true,
                directory: "bower_components"
            },
            "prod": {
                options: {
                    production: true
                }
            },
            "dev": {
                options: {
                    production: false
                }
            }
        },
        less: {
            Home: {
                files:                
                    {
                        './build/css/Home.css': './less/MainHome.less'
                    }                
            },
            Dashboard: {
                files:                 
                    {
                        './build/css/Dashboard.css': './less/MainDashboard.less'
                    }                
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            CSSHome:{
                src: [
                  './build/css/Home.css'
                ],
                dest: './build/css/home-sigma.css'
            },
            CSSDashboard: {
                src: [
                  './build/css/Dashboard.css'
                ],
                dest: './build/css/dashboard-sigma.css'
            },
            JS: {
                src: [
                    './bower_components/jquery/dist/jquery.js',
                    './bower_components/jquery-pjax/jquery.pjax.js',
                    './bower_components/jquery-validation/dist/jquery.validate.min.js',
                    './bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js',
                    './bower_components/jquery.scrollTo/jquery.scrollTo.min.js',
                    './bower_components/bootstrap/dist/js/bootstrap.js',
                    './bower_components/accounting.js/accounting.min.js',
                    './bower_components/toastr/toastr.js',
                    './bower_components/Chart.js/Chart.js',
                    './js/**/*.js'
                ],
                dest: './build/js/sigma.js'
            }
        },

        cssmin: {
            CSSHome: {
                src: './build/css/home-sigma.css',
                dest: './build/css/home-sigma.min.css'
            },
            CSSDashboard: {
                src: './build/css/dashboard-sigma.css',
                dest: './build/css/dashboard-sigma.min.css'
            }
        },

        uglify: {
            js: {
                files: {
                    './build/js/sigma.min.js': './build/js/sigma.js'
                }
            }
        },
        clean: {
            BuildFiles: ['./build/css/Home.css', './build/css/Dashboard.css']
        },
        watch: {
            files: ['./js/**/*.js', './less/**/*.less'],
            tasks: ['default']
        }
    });

    grunt.loadNpmTasks("grunt-bower-install-simple");
    grunt.loadNpmTasks('grunt-contrib-less');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.registerTask("bower-install", ["bower-install-simple"]);
    grunt.registerTask('default', ['bower-install-simple', 'less', 'concat', 'cssmin', 'uglify', 'clean']);


};