#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture_diffuse1;
uniform sampler2D texture_specular1;

void main()
{     
    FragColor = vec4(vec3(texture(texture_diffuse1, TexCoords)) + vec3(0.5*texture(texture_specular1, TexCoords)), 1.0f);
}


