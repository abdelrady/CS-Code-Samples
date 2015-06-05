<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
	<select name="cboItems" >
	<option value="-">--- Districts ---</option>
	<xsl:for-each select="users/user">		
	<option>
	<xsl:attribute name="value">
          <xsl:value-of select="id" />
    </xsl:attribute>
    <xsl:value-of select="name" />
	</option>
	</xsl:for-each>	
	</select>
</xsl:template>
</xsl:stylesheet>
