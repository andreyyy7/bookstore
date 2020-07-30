<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>My Books</h2>
        <table border="1">
          <tr>
            <th>Title</th>
            <th>Author</th>
            <th>Category</th>
            <th>Year</th>
            <th>Price</th>
          </tr>
          <xsl:for-each select="bookstore/book">
            <tr>
              <td>
                <xsl:value-of select="title"/>
              </td>
              <td>
                <xsl:for-each select="author">
                  <xsl:value-of select="current()"/>
                  <xsl:if test="position() != last()">
                    <xsl:text>; </xsl:text>
                  </xsl:if>
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="@category"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>