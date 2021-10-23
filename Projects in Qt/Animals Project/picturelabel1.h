#ifndef PICTURELABEL1_H
#define PICTURELABEL1_H

#include <QObject>
#include <QLabel>

class PictureLabel1 : public QLabel
{
    Q_OBJECT
public:
    PictureLabel1(QWidget* parent = nullptr);
protected:
    void enterEvent(QEvent* event) override;
    void leaveEvent(QEvent* event) override;
    void mousePressEvent(QMouseEvent* event) override;
};

#endif // PICTURELABEL1_H
