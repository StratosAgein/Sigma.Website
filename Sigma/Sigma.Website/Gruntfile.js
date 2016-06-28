module.exports = function (grunt) {

    grunt.initConfig({
        "bower-install-simple": {
            options: {
                color: true,
                directory: "bower_components"
            },
            "prod": {
                options: {
                    production: false
                }
            },
            "dev": {
                options: {
                    production: true
                }
            }
        },
        less: {
            production: {
                files: {
                    'Main.css': './less/Main.less'
                }
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            css: {
                src: [
                  'Main.css',
                ],
                dest: 'sigma.css'
            },
            js: {
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
            css: {
                src: 'sigma.css',
                dest: 'sigma.min.css'
            }
        },

        uglify: {
            js: {
                files: {
                    'sigma.min.js': 'sigma.js'
                }
            }
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

    grunt.registerTask("bower-install", ["bower-install-simple"]);
    grunt.registerTask('default', ['bower-install-simple', 'less', 'concat', 'cssmin', 'uglify']);


};