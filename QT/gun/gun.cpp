#include "gun.h"

gun::gun()
{
}

void gun:: draw()
{
    scene-> addRect(QRectF(0, 0, 100, 100));
}
