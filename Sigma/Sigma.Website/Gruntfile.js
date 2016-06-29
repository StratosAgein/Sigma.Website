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
                        './build/Home.css': './less/MainHome.less'
                    }                
            },
            Dashboard: {
                files:                 
                    {
                        './build/Dashboard.css': './less/MainDashboard.less'
                    }                
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            CSSHome:{
                src: [
                  './build/Home.css'
                ],
                dest: './build/home-sigma.css'
            },
            CSSDashboard: {
                src: [
                  './build/Dashboard.css'
                ],
                dest: './build/dashboard-sigma.css'
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
                dest: 'sigma.js'
            }
        },

        cssmin: {
            CSSHome: {
                src: './build/home-sigma.css',
                dest: './build/home-sigma.min.css'
            },
            CSSDashboard: {
                src: './build/dashboard-sigma.css',
                dest: './build/dashboard-sigma.min.css'
            }
        },

        uglify: {
            js: {
                files: {
                    'sigma.min.js': 'sigma.js'
                }
            }
        },
        clean: {
            BuildFiles: ['./build/Home.css', './build/Dashboard.css']
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