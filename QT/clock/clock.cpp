#include "clock.h"
#include <QtWidgets>

Clock::Clock(QWidget *parent)
    : QWidget(parent)
{
    QTimer *timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(update()));
    timer->start(1000);
    setWindowTitle(tr("This Clock"));
    resize(250, 250);
}

void Clock::paintEvent(QPaintEvent *)
{
    QPoint hourHand[3] =
    {
        QPoint(7, 8),
        QPoint(-7, 8),
        QPoint(0, -35)
    };

    QPoint minuteHand[3] =
    {
        QPoint(7, 8),
        QPoint(-7, 8),
        QPoint(0, -75)
    };

    int side = qMin(width(), height());
    QTime time = QTime::currentTime();

    QPainter painter(this);
    painter.setRenderHint(QPainter::Antialiasing);
    painter.translate(width() / 2, height() / 2);
    painter.scale(side / 200.0, side / 200.0);

    painter.setPen(Qt::blue);
    painter.setBrush(Qt::black);

    painter.save();
    painter.rotate(30.0 * ((time.hour() + time.minute() / 60.0)));
    painter.drawConvexPolygon(hourHand, 3);
    painter.restore();

    painter.setPen(Qt::black);

    for (int i = 0; i < 12; ++i)
    {
        painter.drawLine(88, 0, 96, 0);
        painter.rotate(30.0);
    }

    painter.setPen(Qt::blue);
    painter.setBrush(Qt::black);

    painter.save();
    painter.rotate(6.0 * (time.minute() + time.second() / 60.0));
    painter.drawConvexPolygon(minuteHand, 3);
    painter.restore();

    painter.setPen(Qt::blue);

    for (int j = 0; j < 60; ++j) {
        if ((j % 5) != 0)
            painter.drawLine(92, 0, 96, 0);
        painter.rotate(6.0);
    }
}
