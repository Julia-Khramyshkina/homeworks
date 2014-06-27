#pragma once
#include <QWidget>

class Clock : public QWidget
{
    Q_OBJECT

public:
    Clock(QWidget *parent = 0);

protected:
    void paintEvent(QPaintEvent *event);
};
