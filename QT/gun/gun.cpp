#include "gun.h"
#include <QTransform>

gun::gun()
{
}
QRectF gun::boundingRect() const
    {
     qreal penWidth = 1;
     return QRectF(-10 - penWidth / 2, -10 - penWidth / 2,
                   20 + penWidth, 20 + penWidth);
    }



void gun:: paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawEllipse(10, 200, 100, 70);


    painter->drawRect(110, 230, 40, 10);
}

