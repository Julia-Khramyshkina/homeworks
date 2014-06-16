#pragma once
#include <QGraphicsScene>
#include <QGraphicsView>

class target
{
public:
    target(QGraphicsScene *somethingScene);
    void draw();

private:
    QGraphicsScene *scene;
};
