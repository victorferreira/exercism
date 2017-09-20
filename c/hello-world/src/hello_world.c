#include <stdio.h>
#include <stddef.h>
#include "hello_world.h"

void hello(char *buffer, const char *name)
{
    if (!name)
    {
        sprintf(buffer, "Hello, World!");
    }
    else
    {
        sprintf(buffer, "Hello, %s!", name);
    }
}
