#pragma once
#include <QGraphicsScene>
#include <QGraphicsView>

class target
{
public:
    target();
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

};
