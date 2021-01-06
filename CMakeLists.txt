cmake_minimum_required(VERSION 3.0)

project(lightningtut)

set(MySources main.cpp)

add_executable(lightningtut main.cpp glad.c)

target_link_libraries(lightningtut
    glfw
    glut
    GL
    dl
    assimp
)

install(TARGETS lightningtut RUNTIME DESTINATION bin)

