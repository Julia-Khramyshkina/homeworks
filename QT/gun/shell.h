#pragma once

#include "mainwindow.h"

#include <QGraphicsScene>

#include <QGraphicsView>

#include <QGraphicsItem>

#include <QWidget>

class Shell : public QGraphicsItem
{
public:
    Shell(qreal x, qreal y, qreal speed);

    /// Rectangle for paint shell.
    QRectF boundingRect() const;

    /// Paint shell.
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

    /// Processing of flight.
    void fly();

    /// Get value from position from x.
    qreal posX();

    /// Get value from position from y.
    qreal posY();

private:
    qreal shift;
    qreal turn;
    QPointF coordinate;
    qreal speed = 0;
    QPointF speedVector;
    QPointF g;
};

